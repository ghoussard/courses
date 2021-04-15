const Grid = require('./grid')

module.exports = class {

  constructor() {
    this.grid = new Grid()
    this.rewardGrid = null
  }

  /**
   * Affiche la grille
   */
  displayGrid() {
    this.grid.display()
  }

  /**
   * Affiche la grille des récompenses
   */
  displayRewardGrid() {
    this.rewardGrid.display()
  }

  /**
   * Explore la grille
   */
  explore() {
    //on récupère les déplacements possibles
    const possibleNextPositions = this.grid.getPossibleNextPositions()

    //on choisi le déplacement avec un random
    const nextPosition = possibleNextPositions[Math.floor(Math.random() * possibleNextPositions.length)];

    //on se déplace
    this.grid.move(nextPosition)
  }

  /**
   * La grille est-elle complétée ? (une récompense trouvée)
   */
  isCompleted() {
    return this.grid.currentPositionIsAReward()
  }

  /**
   * Applique les récompense sur la grille
   */
  reward() {
    if(null === this.rewardGrid) this.rewardGrid = { ...this.grid }; this.rewardGrid.display = this.grid.display

    //on part de la case courante
    let previous = this.grid.getCurrentReward()

    //on reprend l'historique depuis la fin pour calculer les récompenses
    for(let current of this.grid.history.reverse()) {
        this.rewardGrid.grid[current[0]][current[1]].value = this.rewardGrid.grid[current[0]][current[1]].value + previous * 0.0001
        previous = this.rewardGrid.grid[current[0]][current[1]].value
    }
  }
}
