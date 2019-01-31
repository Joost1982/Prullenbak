
// identify de cellen

var cell1 = document.getElementById('cell1');
var cell2 = document.getElementById('cell2');
var cell3 = document.getElementById('cell3');
var cell4 = document.getElementById('cell4');
var cell5 = document.getElementById('cell5');
var cell6 = document.getElementById('cell6');
var cell7 = document.getElementById('cell7');
var cell8 = document.getElementById('cell8');
var cell9 = document.getElementById('cell9');
var scoreveld = document.getElementById('score');

// scorematrix

var score = [['','',''], ['','',''], ['','','']]

// scorefunctie

function checkScore() {

  // X wint

  //rij 1,2,3
  if (score[0][0] === 'X' && score[0][1] === 'X' && score[0][2] === 'X') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>X heeft gewonnen!!"
  }
  //rij 4,5,6
  else if (score[1][0] === 'X' && score[1][1] === 'X' && score[1][2] === 'X') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>X heeft gewonnen!!"
  }
  //rij 7,8,9
  else if (score[2][0] === 'X' && score[2][1] === 'X' && score[2][2] === 'X') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>X heeft gewonnen!!"
  }
  //rij 1,4,7
  else if (score[0][0] === 'X' && score[1][0] === 'X' && score[2][0] === 'X') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>X heeft gewonnen!!"
  }
  //rij 2, 5, 8
  else if (score[0][1] === 'X' && score[1][1] === 'X' && score[2][1] === 'X') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>X heeft gewonnen!!"
  }
  //rij 3, 6, 9
  else if (score[0][2] === 'X' && score[1][2] === 'X' && score[2][2] === 'X') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>X heeft gewonnen!!"
  }
  //rij 1, 5, 9
  else if (score[0][0] === 'X' && score[1][1] === 'X' && score[2][2] === 'X') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>X heeft gewonnen!!"
  }
  //rij 3,5,7
  else if (score[0][2] === 'X' && score[1][1] === 'X' && score[2][0] === 'X') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>X heeft gewonnen!!"
  }
  // O wint

  //rij 1,2,3
  else if (score[0][0] === 'O' && score[0][1] === 'O' && score[0][2] === 'O') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>O heeft gewonnen!!"
  }
  //rij 4,5,6
  else if (score[1][0] === 'O' && score[1][1] === 'O' && score[1][2] === 'O') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>O heeft gewonnen!!"
  }
  //rij 7,8,9
  else if (score[2][0] === 'O' && score[2][1] === 'O' && score[2][2] === 'O') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>O heeft gewonnen!!"
  }
  //rij 1,4,7
  else if (score[0][0] === 'O' && score[1][0] === 'O' && score[2][0] === 'O') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>O heeft gewonnen!!"
  }
  //rij 2, 5, 8
  else if (score[0][1] === 'O' && score[1][1] === 'O' && score[2][1] === 'O') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>O heeft gewonnen!!"
  }
  //rij 3, 6, 9
  else if (score[0][2] === 'O' && score[1][2] === 'O' && score[2][2] === 'O') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>O heeft gewonnen!!"
  }
  //rij 1, 5, 9
  else if (score[0][0] === 'O' && score[1][1] === 'O' && score[2][2] === 'O') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>O heeft gewonnen!!"
  }
  //rij 3,5,7
  else if (score[0][2] === 'O' && score[1][1] === 'O' && score[2][0] === 'O') {
    scoreveld.innerHTML = "<img src=\"http://newyorkparkingticket.com/wp-content/uploads/2009/09/NYPT-WIN_how-to-beat-a-NYC-parking-ticket.png\"><br>O heeft gewonnen!!"
  }


  else {
    scoreveld.innerHTML = 'Nog geen winnaar...'
  }
}

// cell 1

function veranderInhoud1() {
  if (cell1.innerHTML === "") {
     cell1.innerHTML= "X";
     score[0][0] = "X";
  } else if (cell1.innerHTML === "X") {
    cell1.innerHTML= "O";
      score[0][0] = "O";
  } else {
    cell1.innerHTML= "";
    score[0][0] = "";
  }
  checkScore()
}


// cell 2

function veranderInhoud2() {
  if (cell2.innerHTML === "") {
     cell2.innerHTML= "X";
     score[0][1] = "X";
  } else if (cell2.innerHTML === "X") {
    cell2.innerHTML= "O";
      score[0][1] = "O";
  } else {
    cell2.innerHTML= "";
    score[0][1] = "";
  }
}

// cell 3

function veranderInhoud3() {
  if (cell3.innerHTML === "") {
     cell3.innerHTML= "X";
     score[0][2] = "X";
  } else if (cell3.innerHTML === "X") {
    cell3.innerHTML= "O";
      score[0][2] = "O";
  } else {
    cell3.innerHTML= "";
    score[0][2] = "";
  }
  checkScore()
}

// cell 4

function veranderInhoud4() {
  if (cell4.innerHTML === "") {
     cell4.innerHTML= "X";
     score[1][0] = "X";
  } else if (cell4.innerHTML === "X") {
    cell4.innerHTML= "O";
      score[1][0] = "O";
  } else {
    cell4.innerHTML= "";
    score[1][0] = "";
  }
  checkScore()
}

// cell 5

function veranderInhoud5() {
  if (cell5.innerHTML === "") {
     cell5.innerHTML= "X";
     score[1][1] = "X";
  } else if (cell5.innerHTML === "X") {
    cell5.innerHTML= "O";
      score[1][1] = "O";
  } else {
    cell5.innerHTML= "";
    score[1][1] = "";
  }
    checkScore()
}

// cell 6

function veranderInhoud6() {
  if (cell6.innerHTML === "") {
     cell6.innerHTML= "X";
     score[1][2] = "X";
  } else if (cell6.innerHTML === "X") {
    cell6.innerHTML= "O";
      score[1][2] = "O";
  } else {
    cell6.innerHTML= "";
    score[1][2] = "";
  }
    checkScore()
}

// cell 7

function veranderInhoud7() {
  if (cell7.innerHTML === "") {
     cell7.innerHTML= "X";
     score[2][0] = "X";
  } else if (cell7.innerHTML === "X") {
    cell7.innerHTML= "O";
      score[2][0] = "O";
  } else {
    cell7.innerHTML= "";
    score[2][0] = "";
  }
    checkScore()
}

// cell 8

function veranderInhoud8() {
  if (cell8.innerHTML === "") {
     cell8.innerHTML= "X";
     score[2][1] = "X";
  } else if (cell8.innerHTML === "X") {
    cell8.innerHTML= "O";
      score[2][1] = "O";
  } else {
    cell8.innerHTML= "";
    score[2][1] = "";
  }
    checkScore()
}

// cell 9

function veranderInhoud9() {
  if (cell9.innerHTML === "") {
     cell9.innerHTML= "X";
     score[2][2] = "X";
  } else if (cell9.innerHTML === "X") {
    cell9.innerHTML= "O";
      score[2][2] = "O";
  } else {
    cell9.innerHTML= "";
    score[2][2] = "";
  }
    checkScore()
}

// event listeners

cell1.addEventListener("click", veranderInhoud1);
cell2.addEventListener("click", veranderInhoud2);
cell3.addEventListener("click", veranderInhoud3);
cell4.addEventListener("click", veranderInhoud4);
cell5.addEventListener("click", veranderInhoud5);
cell6.addEventListener("click", veranderInhoud6);
cell7.addEventListener("click", veranderInhoud7);
cell8.addEventListener("click", veranderInhoud8);
cell9.addEventListener("click", veranderInhoud9);


////////////// later toegevoegd (nu hoeft de pagina niet herladen te worden, is sneller)

// restart button

var restart = document.getElementById('restartb');

// pak alle cellen

var cellen = document.querySelectorAll('td');

// maak bord leeg

function leegBord() {
  for (var i = 0; i < cellen.length; i++) {
    cellen[i].textContent = '';
  }
  scoreveld.innerHTML = 'Nog geen winnaar...'
}

// restart.addEventListener('click', leegBord);

function Opnieuw() {
	location.reload()
}

restart.addEventListener('click', Opnieuw);

