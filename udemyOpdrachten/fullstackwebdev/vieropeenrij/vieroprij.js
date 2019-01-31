// spelvariabelen
var speler = 0; //0 = rood, 1 = blauw
var kolom1 = 35;
var kolom2 = 36;
var kolom3 = 37;
var kolom4 = 38;
var kolom5 = 39;
var kolom6 = 40;
var kolom7 = 41;
var rijkolom1 = 5;
var rijkolom2 = 5;
var rijkolom3 = 5;
var rijkolom4 = 5;
var rijkolom5 = 5;
var rijkolom6 = 5;
var rijkolom7 = 5;

speelbord =[[0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 0] ];

// identify doms
var spelinfo = document.querySelectorAll('h3');   // pak h3 (voor spelinfo)
var cellen = document.querySelectorAll('td');   // pak alle cellen
//var restart = document.getElementById('restartb');  // button

// evenlistener voor alle kolommen
// kolom 1
for (var i = 0; i < cellen.length; i+=7) {
     $('td').eq(i).click(kleurVakje1);
    }
// kolom 2
for (var i = 1; i < cellen.length; i+=7) {
     $('td').eq(i).click(kleurVakje2);
    }
// kolom 3
for (var i = 2; i < cellen.length; i+=7) {
    $('td').eq(i).click(kleurVakje3);
    }
// kolom 4
for (var i = 3; i < cellen.length; i+=7) {
     $('td').eq(i).click(kleurVakje4);
    }
// kolom 5
for (var i = 4; i < cellen.length; i+=7) {
     $('td').eq(i).click(kleurVakje5);
    }
// kolom 6
for (var i = 5; i < cellen.length; i+=7) {
     $('td').eq(i).click(kleurVakje6);
    }
// kolom 7
for (var i = 6; i < cellen.length; i+=7) {
     $('td').eq(i).click(kleurVakje7);
    }

// // maak bord leeg
// function leegBord() {
//   for (var i = 0; i < cellen.length; i++) {
//     $(cellen[i]).removeClass('blauw');
//     $(cellen[i]).removeClass('rood');
//   }
// }

// listener om veld schoon te maken
//restart.addEventListener('click', leegBord);

// toggle blauw of rood
// kolom 1
function kleurVakje1() {
  if (speler === 0 && kolom1 !== -7) {
    // MAAK ROOD
    //$(this).toggleClass('rood');
    $(cellen[kolom1]).removeClass('blauw');
    $(cellen[kolom1]).addClass('rood');
    // console.log('rood');
    $(spelinfo).text('Speler blauw is aan de beurt!');
    speler = 1;
    kolom1 = kolom1 - 7;
    //console.log(speelbord);
  }
  else if (speler === 1 && kolom1 !== -7) {
    // MAAK BLAUW
    $(cellen[kolom1]).removeClass('rood');
    $(cellen[kolom1]).addClass('blauw');
    //console.log('blauw');
    $(spelinfo).text('Speler rood is aan de beurt!');
    speler = 0;
    kolom1 = kolom1 - 7;
    //console.log(speelbord);
  }
  else {
      //foutmelding ivm volle rij
      if (speler === 0) {
        $(spelinfo).text('Fout, rij is al vol! (speler rood nog aan de beurt)');
      } else {
        $(spelinfo).text('Fout, rij is al vol! (speler blauw nog aan de beurt)');
      }
     }
     // werk "virtuele" speelbord bij
     if (speler === 1) {
         speelbord[rijkolom1][0] = 1;
     } else {
         speelbord[rijkolom1][0] = 2;
     }
     rijkolom1 = rijkolom1 - 1;
     //check score!
     //console.log(speelbord);
     if (chkWinner(speelbord) === 1) {
        $(spelinfo).text('Rood heeft gewonnen!!!');
        $('.container2').slideUp(3000);
     } else if (chkWinner(speelbord) === 2) {
        $('.container2').slideUp(3000);
        $(spelinfo).text('Blauw heeft gewonnen!!!');
     }
     //console.log('Winnaar: ' + chkWinner(speelbord));
     //console.log(rijkolom1);
   }

 // kolom 2
 function kleurVakje2() {
   if (speler === 0 && kolom2 !== -6) {
     // MAAK ROOD
     //$(this).toggleClass('rood');
     $(cellen[kolom2]).removeClass('blauw');
     $(cellen[kolom2]).addClass('rood');

    // console.log('rood');
     $(spelinfo).text('Speler blauw is aan de beurt!');
     speler = 1;
     kolom2 = kolom2 - 7;
   }
   else if (speler === 1 && kolom2 !== -6) {
     // MAAK BLAUW
     $(cellen[kolom2]).removeClass('rood');
     $(cellen[kolom2]).addClass('blauw');
     //console.log('blauw');
     $(spelinfo).text('Speler rood is aan de beurt!');
     speler = 0;
     kolom2 = kolom2 - 7;
   }
   else {
       //foutmelding ivm volle rij
       if (speler === 0) {
         $(spelinfo).text('Fout, rij is al vol! (speler rood nog aan de beurt)');
       } else {
         $(spelinfo).text('Fout, rij is al vol! (speler blauw nog aan de beurt)');
       }
      }
      // werk "virtuele" speelbord bij
      if (speler === 1) {
          speelbord[rijkolom2][1] = 1;
      } else {
          speelbord[rijkolom2][1] = 2;
      }
      rijkolom2 = rijkolom2 - 1;
      //check score!
      //console.log(speelbord);
      if (chkWinner(speelbord) === 1) {
         $(spelinfo).text('Rood heeft gewonnen!!!');
         $('.container2').slideUp(3000);
      } else if (chkWinner(speelbord) === 2) {

         $('.container2').slideUp(3000);
         $(spelinfo).text('Blauw heeft gewonnen!!!');
      }
      //console.log('Winnaar: ' + chkWinner(speelbord));
      //console.log(rijkolom1);
    }

// kolom 3
function kleurVakje3() {
  if (speler === 0 && kolom3 !== -5) {
    // MAAK ROOD
    //$(this).toggleClass('rood');
    $(cellen[kolom3]).removeClass('blauw');
    $(cellen[kolom3]).addClass('rood');
    // console.log('rood');
    $(spelinfo).text('Speler blauw is aan de beurt!');
    speler = 1;
    kolom3 = kolom3 - 7;
  }
  else if (speler === 1 && kolom3 !== -5) {
    // MAAK BLAUW
    $(cellen[kolom3]).removeClass('rood');
    $(cellen[kolom3]).addClass('blauw');
    //console.log('blauw');
    $(spelinfo).text('Speler rood is aan de beurt!');
    speler = 0;
    kolom3 = kolom3 - 7;
  }
  else {
      //foutmelding ivm volle rij
      if (speler === 0) {
        $(spelinfo).text('Fout, rij is al vol! (speler rood nog aan de beurt)');
      } else {
        $(spelinfo).text('Fout, rij is al vol! (speler blauw nog aan de beurt)');
      }
     }
     // werk "virtuele" speelbord bij
     if (speler === 1) {
         speelbord[rijkolom3][2] = 1;
     } else {
         speelbord[rijkolom3][2] = 2;
     }
     rijkolom3 = rijkolom3 - 1;
     //check score!
     //console.log(speelbord);
     if (chkWinner(speelbord) === 1) {
        $(spelinfo).text('Rood heeft gewonnen!!!');
        $('.container2').slideUp(3000);
     } else if (chkWinner(speelbord) === 2) {

        $('.container2').slideUp(3000);
        $(spelinfo).text('Blauw heeft gewonnen!!!');
     }
     //console.log('Winnaar: ' + chkWinner(speelbord));
     //console.log(rijkolom1);
   }

 // kolom 4
 function kleurVakje4() {
   if (speler === 0 && kolom4 !== -4) {
     // MAAK ROOD
     //$(this).toggleClass('rood');
     $(cellen[kolom4]).removeClass('blauw');
     $(cellen[kolom4]).addClass('rood');
     // console.log('rood');
     $(spelinfo).text('Speler blauw is aan de beurt!');
     speler = 1;
     kolom4 = kolom4 - 7;
   }
   else if (speler === 1 && kolom4 !== -4) {
     // MAAK BLAUW
     $(cellen[kolom4]).removeClass('rood');
     $(cellen[kolom4]).addClass('blauw');
     //console.log('blauw');
     $(spelinfo).text('Speler rood is aan de beurt!');
     speler = 0;
     kolom4 = kolom4 - 7;
   }
   else {
       //foutmelding ivm volle rij
       if (speler === 0) {
         $(spelinfo).text('Fout, rij is al vol! (speler rood nog aan de beurt)');
       } else {
         $(spelinfo).text('Fout, rij is al vol! (speler blauw nog aan de beurt)');
       }
      }
      // werk "virtuele" speelbord bij
      if (speler === 1) {
          speelbord[rijkolom4][3] = 1;
      } else {
          speelbord[rijkolom4][3] = 2;
      }
      rijkolom4 = rijkolom4 - 1;
      //check score!
      //console.log(speelbord);
      if (chkWinner(speelbord) === 1) {
         $(spelinfo).text('Rood heeft gewonnen!!!');
         $('.container2').slideUp(3000);
      } else if (chkWinner(speelbord) === 2) {

         $('.container2').slideUp(3000);
         $(spelinfo).text('Blauw heeft gewonnen!!!');
      }
      //console.log('Winnaar: ' + chkWinner(speelbord));
      //console.log(rijkolom1);
    }

// kolom 5
function kleurVakje5() {
  if (speler === 0 && kolom5 !== -3) {
    // MAAK ROOD
    //$(this).toggleClass('rood');
    $(cellen[kolom5]).removeClass('blauw');
    $(cellen[kolom5]).addClass('rood');
    // console.log('rood');
    $(spelinfo).text('Speler blauw is aan de beurt!');
    speler = 1;
    kolom5 = kolom5 - 7;
  }
  else if (speler === 1 && kolom5 !== -3) {
    // MAAK BLAUW
    $(cellen[kolom5]).removeClass('rood');
    $(cellen[kolom5]).addClass('blauw');
    //console.log('blauw');
    $(spelinfo).text('Speler rood is aan de beurt!');
    speler = 0;
    kolom5 = kolom5 - 7;
  }
  else {
      //foutmelding ivm volle rij
      if (speler === 0) {
        $(spelinfo).text('Fout, rij is al vol! (speler rood nog aan de beurt)');
      } else {
        $(spelinfo).text('Fout, rij is al vol! (speler blauw nog aan de beurt)');
      }
     }
     // werk "virtuele" speelbord bij
     if (speler === 1) {
         speelbord[rijkolom5][4] = 1;
     } else {
         speelbord[rijkolom5][4] = 2;
     }
     rijkolom5 = rijkolom5 - 1;
     //check score!
     //console.log(speelbord);
     if (chkWinner(speelbord) === 1) {
        $(spelinfo).text('Rood heeft gewonnen!!!');
        $('.container2').slideUp(3000);
     } else if (chkWinner(speelbord) === 2) {

        $('.container2').slideUp(3000);
        $(spelinfo).text('Blauw heeft gewonnen!!!');
     }
     //console.log('Winnaar: ' + chkWinner(speelbord));
     //console.log(rijkolom1);
   }

 // kolom 6
 function kleurVakje6() {
   if (speler === 0 && kolom6 !== -2) {
     // MAAK ROOD
     //$(this).toggleClass('rood');
     $(cellen[kolom6]).removeClass('blauw');
     $(cellen[kolom6]).addClass('rood');
     // console.log('rood');
     $(spelinfo).text('Speler blauw is aan de beurt!');
     speler = 1;
     kolom6 = kolom6 - 7;
   }
   else if (speler === 1 && kolom6 !== -2) {
     // MAAK BLAUW
     $(cellen[kolom6]).removeClass('rood');
     $(cellen[kolom6]).addClass('blauw');
     //console.log('blauw');
     $(spelinfo).text('Speler rood is aan de beurt!');
     speler = 0;
     kolom6 = kolom6 - 7;
   }
   else {
       //foutmelding ivm volle rij
       if (speler === 0) {
         $(spelinfo).text('Fout, rij is al vol! (speler rood nog aan de beurt)');
       } else {
         $(spelinfo).text('Fout, rij is al vol! (speler blauw nog aan de beurt)');
       }
      }
      // werk "virtuele" speelbord bij
      if (speler === 1) {
          speelbord[rijkolom6][5] = 1;
      } else {
          speelbord[rijkolom6][5] = 2;
      }
      rijkolom6 = rijkolom6 - 1;
      //check score!
      //console.log(speelbord);
      if (chkWinner(speelbord) === 1) {
         $(spelinfo).text('Rood heeft gewonnen!!!');
         $('.container2').slideUp(3000);
      } else if (chkWinner(speelbord) === 2) {

         $('.container2').slideUp(3000);
         $(spelinfo).text('Blauw heeft gewonnen!!!');
      }
      //console.log('Winnaar: ' + chkWinner(speelbord));
      //console.log(rijkolom1);
    }

// kolom 7
function kleurVakje7() {
  if (speler === 0 && kolom7 !== -1) {
    // MAAK ROOD
    //$(this).toggleClass('rood');
    $(cellen[kolom7]).removeClass('blauw');
    $(cellen[kolom7]).addClass('rood');
    // console.log('rood');
    $(spelinfo).text('Speler blauw is aan de beurt!');
    speler = 1;
    kolom7 = kolom7 - 7;
  }
  else if (speler === 1 && kolom7 !== -1) {
    // MAAK BLAUW
    $(cellen[kolom7]).removeClass('rood');
    $(cellen[kolom7]).addClass('blauw');
    //console.log('blauw');
    $(spelinfo).text('Speler rood is aan de beurt!');
    speler = 0;
    kolom7 = kolom7 - 7;
  }
  else {
      //foutmelding ivm volle rij
      if (speler === 0) {
        $(spelinfo).text('Fout, rij is al vol! (speler rood nog aan de beurt)');
      } else {
        $(spelinfo).text('Fout, rij is al vol! (speler blauw nog aan de beurt)');
      }
     }
     // werk "virtuele" speelbord bij
     if (speler === 1) {
         speelbord[rijkolom7][6] = 1;
     } else {
         speelbord[rijkolom7][6] = 2;
     }
     rijkolom7 = rijkolom7 - 1;
     //check score!
     //console.log(speelbord);
     if (chkWinner(speelbord) === 1) {
        $(spelinfo).text('Rood heeft gewonnen!!!');
        $('.container2').slideUp(3000);
     } else if (chkWinner(speelbord) === 2) {

        $('.container2').slideUp(3000);
        $(spelinfo).text('Blauw heeft gewonnen!!!');
     }
     //console.log('Winnaar: ' + chkWinner(speelbord));
     //console.log(rijkolom1);
   }


// schaamteloze kopie van stackoverflow
// https://stackoverflow.com/questions/33181356/connect-four-game-checking-for-wins-js


function chkLine(a,b,c,d) {
    // Check first cell non-zero and all cells match
    return ((a !== 0) && (a ===b) && (a === c) && (a === d));
}

function chkWinner(bd) {
    // Check down
    for (r = 0; r < 3; r++)
        for (c = 0; c < 7; c++)
            if (chkLine(bd[r][c], bd[r+1][c], bd[r+2][c], bd[r+3][c]))
                return bd[r][c];

    // Check right
    for (r = 0; r < 6; r++)
        for (c = 0; c < 4; c++)
            if (chkLine(bd[r][c], bd[r][c+1], bd[r][c+2], bd[r][c+3]))
                return bd[r][c];

    // Check down-right
    for (r = 0; r < 3; r++)
        for (c = 0; c < 4; c++)
            if (chkLine(bd[r][c], bd[r+1][c+1], bd[r+2][c+2], bd[r+3][c+3]))
                return bd[r][c];

    // Check down-left
    for (r = 3; r < 6; r++)
        for (c = 0; c < 4; c++)
            if (chkLine(bd[r][c], bd[r-1][c+1], bd[r-2][c+2], bd[r-3][c+3]))
                return bd[r][c];

    return 0;
}



// x =[ [0, 0, 0, 0, 0, 0, 0],
//      [0, 0, 0, 0, 0, 0, 0],
//      [0, 0, 0, 1, 1, 0, 0],
//      [0, 0, 0, 1, 1, 0, 0],
//      [0, 0, 1, 2, 2, 2, 0],
//      [0, 1, 2, 2, 1, 2, 0] ];
// alert(chkWinner(x));
