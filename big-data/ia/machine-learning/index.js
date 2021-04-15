const State = require('./src/state')
const state = new State()

// // UN SEUL PARCOURS
// console.log('--- DÉPART (1 PARCOURS) ---\n')
// state.displayGrid()

// let i = 1
// while(!state.isCompleted()) {
//   state.explore()

//   console.log(`\n --- ITÉRATION ${i} ---\n`)
//   state.displayGrid()

//   i++
// }

// console.log('--- FIN ---\n')

// console.log(`Le parcours a nécéssité ${i-1} itérations\n`)

// state.reward()
// state.displayRewardGrid()

// PLUSIEURS PARCOURS

for(let i = 0; i < 1000; i++) {
  while(!state.isCompleted()) {
    state.explore()
  }

  state.reward()
}

state.displayRewardGrid()
