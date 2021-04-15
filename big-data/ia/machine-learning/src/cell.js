module.exports = class {
  constructor(value, isWall = false, isHole = false) {
    this.value = value
    this.isWall = isWall
    this.isHole = isHole
  }

  toString() {
    let string = this.value

    if(this.isWall) { 
      string = '/'
    } else if (this.isHole) {
      string = 'X'
    }

    return string
  }
}
