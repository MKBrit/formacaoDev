// Get the score object from local storage and transform it back from json string
const score = JSON.parse(localStorage.getItem('score')) || { // OR USE THIS
    wins: 0,
    losses: 0,
    ties: 0
    };
// If there isn't a score, create one
// if(!score){
//     score = {
//         wins: 0,
//         losses: 0,
//         ties: 0
//     };
// }
function updateScoreElement(){
    document.querySelector('.js-score')
        .innerHTML = `Wins: ${score.wins} Losses: ${score.losses} Ties: ${score.ties}`;
}
function updateResultElement(){
    document.querySelector('.js-result')
        .innerHTML = ``
}
function play(playerMove) {
    //Assign move to cpu
    const rand = Math.random();
    let cpuMove = '';
    let result = '';
    if (rand < 1 / 3)
        cpuMove = 'rock';
    else if (rand >= 1 / 3 && rand < 2 / 3)
        cpuMove = 'paper';
    else if (rand >= 2 / 3)
        cpuMove = 'scissors';

    // Compare moves and update score
    if (playerMove === cpuMove) {
        result = 'It\'s a Tie!'
        score.ties++;
    } else if (playerMove === 'rock' && cpuMove === 'scissors'
        || playerMove === 'scissors' && cpuMove === 'paper'
        || playerMove === 'paper' && cpuMove === 'rock') {
        result = 'You Win!'
        score.wins++;
    } else {
        result = 'You Lose!'
        score.losses++;
    }
    
    // Save score to local storage as json string (NEEDED)
    localStorage.setItem('score', JSON.stringify(score));

    // Update the moves when you click a move
    document.querySelector('.js-moves')
        .innerHTML = `You 
        <img class="move-icon" src="images/${playerMove}-emoji.png">
        VS
        <img class="move-icon" src="images/${cpuMove}-emoji.png">
        CPU`;

    // Update the result
    document.querySelector('.js-result')
        .innerHTML = result;

    // DEBUG
    // console.log('New Game')
    // console.log('Player : ', playerMove)
    // console.log('CPU : ', cpuMove)
}
updateScoreElement();
