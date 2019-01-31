var canvas = document.querySelector('canvas');
canvas.width = window.innerWidth;
canvas.height = window.innerHeight;

var c = canvas.getContext('2d');

// checken of je met muis wat kan doen, zie: https://www.youtube.com/watch?v=vxljFhP2krI&index=4&list=PLpPnRKq7eNW3We9VdCfx9fprhqXHwTPXL

// window.addEventListener('mouseover',
//     function(event) {
//       //console.log(event);
//       console.log(event.x);
//       console.log(cirkelArray[0].x);
//
//     })


// testje. als je "rechts" indrukt, dan wordt cirkel30 heel groot.
document.addEventListener ('keydown',function (event) {
                                  if (event.keyCode === 39) {
                                                            cirkelArray[30].radius=200;
                                                          }
                                                        });

function Cirkel(x, y, dx, dy, radius) {
  this.x = x;
  this.y = y;
  this.dx = dx;
  this.dy = dy;
  this.radius = radius;

  this.draw = function() {
    c.beginPath()
    c.arc(this.x,this.y,this.radius,0,Math.PI * 2);
    c.strokeStyle='blue';
    c.stroke();
  }

  this.update = function() {
        if (this.x + this.radius > innerWidth || this.x - this.radius < 0) { // als cirkel de muur raak, dan andere kant op!
          this.dx = -this.dx;
        }

        if (this.y + this.radius > innerHeight || this.y - this.radius < 0) { // als cirkel de muur raak, dan andere kant op!
          this.dy = -this.dy;
        }

        this.x += this.dx;
        this.y += this.dy;

        this.draw();
  }
}

var cirkelArray = [];

for (var i = 0; i < 150; i++) {
  var x = Math.random() * innerWidth
  var y = Math.random() * innerHeight
  var dx = (Math.random() - 0.5) * 8;
  var dy = (Math.random() - 0.5) * 8;
  var radius =  (Math.random() * 50) +1;
  cirkelArray.push(new Cirkel(x, y, dx, dy, radius))
}

console.log(cirkelArray);

function animate() {
  requestAnimationFrame(animate);
  c.clearRect(0,0,innerWidth, innerHeight);
  for (var i = 0; i < cirkelArray.length; i++) {
    c.strokeStyle = 'black'; // kleur van de rand
    cirkelArray[i].update();
    c.fillStyle = 'green'; // binnenkleur
    c.fill(); // inkleuren
  }

}

animate();
