var canvas = document.querySelector('canvas');
canvas.width = window.innerWidth - 50;
canvas.height = window.innerHeight - 50;

var c = canvas.getContext('2d');

var positiex = 100;
var positiey = 100;
var POS = 'BENEDEN';

function tekenVierkant() {
  if (POS == 'RECHTS') {
    positiex = positiex+10;
    positiey = positiey;
  }
  if (POS == 'LINKS') {
    positiex = positiex-10;
    positiey = positiey;
  }
  if (POS == 'BOVEN') {
    positiex = positiex;
    positiey = positiey-10;
  }
  if (POS == 'BENEDEN') {
    positiex = positiex;
    positiey = positiey+10;
  }
   //teken
    c.fillRect(positiex,positiey,10,10); // x, y, width
    checkMuur();
}


function checkMuur() {
          if (positiex < 0 || positiex > canvas.width || positiey < 0 || positiey > canvas.height) {
            alert('Game Over!')
            window.location.reload();
          }
  }


document.addEventListener ('keydown',function (event) {
                                  if (event.keyCode === 39) {
                                                            POS = 'RECHTS';
                                                            }
                                  if (event.keyCode === 37) {
                                                            POS = 'LINKS';
                                                            }
                                  if (event.keyCode === 38) {
                                                            POS = 'BOVEN';
                                                            }
                                  if (event.keyCode === 40) {
                                                            POS = 'BENEDEN';
                                                            }
                                                      },  false);


setInterval(tekenVierkant, 100);
