var canvas = document.querySelector('canvas');
canvas.width = window.innerWidth;
canvas.height = window.innerHeight;

var c = canvas.getContext('2d');

var positiex = 100;
var positiey = 100;
var kleuren = ["red", "blue", "green", "black","yellow"];

// Return a random number between 1 and 10:
// Math.floor((Math.random() * 10) + 1);

function tekenVierkant() {
    var kleurtje = kleuren[Math.floor((Math.random() * 5) + 0)]
    c.fillStyle = kleurtje;
    c.fillRect(positiex,positiey,100,100); // x, y, width
    positiex = Math.floor((Math.random() * canvas.width - 150) + 1);
    positiey = Math.floor((Math.random() * 1000) + 1);
}



setInterval(tekenVierkant, 10);


//$('canvas').click(tekenVierkant);
