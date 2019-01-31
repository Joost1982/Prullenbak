// snake probeersel (joostvdhorst@gmail.com)
//
// botsingen kloppen nog niet helemaal.
// moet nog toevoegen dat de slang langer wordt (ik denk door het vullen van een array)

var canvas = document.querySelector('canvas');
var sbord = document.querySelector('#scorebordje');
canvas.width = 0.5 * window.innerWidth;
canvas.height = 0.5 * window.innerHeight;

var c = canvas.getContext('2d');

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

var positiex = 100;
var positiey = 100;
var posxD1 = positiex;
var posyD1 = positiey;
var posxD2 = positiex;
var posyD2 = positiey-10;
var posxD3 = positiex;
var posyD3 = positiey-20;
var posxD4 = positiex;
var posyD4 = positiey-30;
var posxD5 = positiex;
var posyD5 = positiey-40;
var eindex = positiex;
var eindey = positiey-50;
var posblokx = 250;
var posbloky = 250;
var POS = 'BENEDEN';
var score = 0;
var kleuren = ['blue','orange','black','yellow','purple','brown','green', 'red'];
var i = 0;

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

   //teken hoofd
    c.fillStyle = 'red';
    c.fillRect(positiex,positiey,10,10); // x, y, width
    //teken lichaam
     c.fillStyle = 'black';
     c.fillRect(posxD1,posyD1,10,10); // x, y, width
     c.fillRect(posxD2,posyD2,10,10); // x, y, width
     c.fillRect(posxD3,posyD3,10,10); // x, y, width

     //teken wit (zodat achterkant wordt "opgegeten" en het een slang lijkt ipv een lijn)
     c.fillStyle = 'white';
     c.fillRect(eindex,eindey,10,10); // x, y, width

     // posities volgende "ronde" (van laatste naar eerste, anders kopier je dezelfde pos in alles!)
     eindex = posxD5;
     eindey = posyD5;
     posxD5 = posxD4;
     posyD5 = posyD4;
     posxD4 = posxD3;
     posyD4 = posyD3;
     posxD3 = posxD2;
     posyD3 = posyD2;
     posxD2 = posxD1;
     posyD2 = posyD1;
     posxD1 = positiex;
     posyD1 = positiey;
    checkMuur();
    checkBlokje();
}


function checkBlokje() { // ik weet niet zeker of de botsingen helemaal goed ingeprogrammeerd staan.... :(
  if (POS=='BENEDEN') {
      if (  (positiey >= posbloky && positiey <= posbloky+10) && (  positiex >= posblokx && positiex <= posblokx+10   ) ) {
        console.log('BOTSING VAN BOVEN!');
        // verander border
        canvas.style.borderColor = kleuren[i];
        if (i < 8) {
          i++;
        } else {
            i = 0;
        }
        //laat blokje "verdwijnen"
        c.fillStyle = 'white';
        c.fillRect(posblokx,posbloky,10,10); // x, y, width

        //c.clearRect(0,0,innerWidth, innerHeight);  //andere optie is bord schoonvegen, maar geeft een glitch

        // hoog score op
        score++;
        sbord.innerHTML = score;
        plaatsBlokje()
      }
    }
  if (POS=='RECHTS') {
      if (  (positiex+10 >= posblokx && positiex <= posblokx+10 ) && ( positiey+10 >= posbloky && positiey <= posbloky+10  ) ) {
        console.log('BOTSING VAN LINKS!');
        // verander border
        canvas.style.borderColor = kleuren[i];
        if (i < 8) {
          i++;
        } else {
            i = 0;
        }
        //laat blokje "verdwijnen"
        c.fillStyle = 'white';
        c.fillRect(posblokx,posbloky,10,10); // x, y, width
        score++;
        sbord.innerHTML = score;
        plaatsBlokje()
      }
    }
  if (POS=='LINKS') {
      if (  (positiex <= posblokx+10 && positiex+10 >= posblokx) && (  positiey+10 >= posbloky && positiey <= posbloky+10   ) ) {
        console.log('BOTSING VAN RECHTS!');
        // verander border
        canvas.style.borderColor = kleuren[i];
        if (i < 8) {
          i++;
        } else {
            i = 0;
        }
        //laat blokje "verdwijnen"
        c.fillStyle = 'white';
        c.fillRect(posblokx,posbloky,10,10); // x, y, width
        score++;
       sbord.innerHTML = score;
        plaatsBlokje()
      }
    }
  if (POS=='BOVEN') {
      if (  (positiex+10 >= posblokx && positiex <= posblokx+10 ) && ( positiey+10 >= posbloky && positiey <= posbloky+10  ) ) {
        console.log('BOTSING VAN BENEDEN!');
        // verander border
        canvas.style.borderColor = kleuren[i];
        if (i < 8) {
          i++;
        } else {
            i = 0;
        }
        //laat blokje "verdwijnen"
        c.fillStyle = 'white';
        c.fillRect(posblokx,posbloky,10,10); // x, y, width
        score++;
        sbord.innerHTML = score;
        plaatsBlokje()
      }
    }
}



function plaatsBlokje() {
        posblokx = Math.floor((Math.random() * (0.5*canvas.width) ) + 1);
        posbloky = Math.floor((Math.random() * (0.5*canvas.height) ) + 1);
            c.fillStyle = 'green';
            c.fillRect(posblokx,posbloky,10,10); // x, y, width
}

function checkMuur() {
          if (positiex < 0 || positiex > canvas.width || positiey < 0 || positiey > canvas.height) {
            alert('Game Over!')
            window.location.reload();
          }
  }

//clear log;
console.clear();
// plaats 1e blokje
c.fillStyle = 'green';
c.fillRect(posblokx,posbloky,10,10); // x, y, width
// start game loop
setInterval(tekenVierkant, 100);
