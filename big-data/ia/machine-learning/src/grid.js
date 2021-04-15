const Cell = require('./cell')
const colors = require('colors')

module.exports = class {
  constructor() {
    this.xSize = 4
    this.ySize = 10
    this.grid = []
    this.history = []

    //construction de la grille
    for(let i = 0; i < this.ySize; i++) {
      this.grid[i] = []

      for(let j = 0; j < this.xSize; j++) {
        let cell

        switch([i, j].join(',')) {
          //récompenses
          case '9,0':
            cell = new Cell(500)
            break
          case '9,2':
            cell = new Cell(1000)
            break
          //trou
          case '9,3':
            cell = new Cell(-1, false, true)
            break
          //murs
          case '0,1':
          case '1,1':
          case '2,1':
          case '3,1':
          case '9,1':
          case '8,1':
          case '7,1':
          case '6,1':
          case '5,1':
            cell = new Cell(0, true)
            break
          //case classique
          default:
            cell = new Cell(0)
            break
        }

        this.grid[i][j] = cell
      }
    }

    //position de départ
    this.currentPosition = [0, 0]
  }

  /**
   * Affiche la grille
   */
  display() {
    for(let i = 0; i < this.ySize; i++) {
      let row = ''

      for(let j = 0; j < this.xSize; j++) {
        let cell = `| ${this.grid[i][j]} |`

        //on met la position actuelle en rouge
        const [currentY, currentX] = this.currentPosition
        if(currentY === i && currentX === j) {
          cell = cell.red
        }

        row += cell
      }

      console.log(row + '\n')
    }
  }

  /**
   * Calcule les futures positions possibles
   */
  getPossibleNextPositions() {
    const nextPossiblePositions = []

    //haut ?
    if(this.currentPosition[0] > 0) {
      nextPossiblePositions.push([this.currentPosition[0]-1, this.currentPosition[1]])
    }

    //bas ?
    if(this.currentPosition[0] < this.ySize-1) {
      nextPossiblePositions.push([this.currentPosition[0]+1, this.currentPosition[1]])
    }

    //gauche ?
    if(this.currentPosition[1] > 0) {
      nextPossiblePositions.push([this.currentPosition[0], this.currentPosition[1]-1])
    }

    //droite ?
    if(this.currentPosition[1] < this.xSize-1) {
      nextPossiblePositions.push([this.currentPosition[0], this.currentPosition[1]+1])
    }

    //on enleve les murs des futures possibles positions
    return nextPossiblePositions.filter(nextPosition => {
      const [nextY, nextX] = nextPosition
      return !this.grid[nextY][nextX].isWall
    })
  }

  /**
   * Déplacement vers position
   * @param position 
   */
  move(position) {
    this.history.push(this.currentPosition)
    this.currentPosition = position
  }

  /**
   * Teste si la postion actuelle est une case avec une récompense
   */
  currentPositionIsAReward() {
    return this.getCurrentReward() !== 0
  }

  /**
   * Récupère la récompense de la case actuelle
   */
  getCurrentReward() {
    const [currentY, currentX] = this.currentPosition
    return this.grid[currentY][currentX].value
  }
}
