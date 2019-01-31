
// pure javascript
//var x = document.querySelector('img')
// console.log(x);

// jquey

console.log($('connected'));

var knoppen = $('button');
var div1 = $('#pic1')
var div2 = $('#pic2')
var div3 = $('#pic3')

knoppen.eq(0).on('click', verbergPic1); // toon pic1, verberg pic2
knoppen.eq(1).on('click', verbergPic2); // verberg pic1, toon pic2
knoppen.eq(2).on('click', verbergPic3); // verberg pic1, toon pic2

function verbergPic1() {
        div1.removeClass('verberg');
        div2.addClass('verberg');
        div3.addClass('verberg');
}

function verbergPic2() {
        div1.addClass('verberg');
        div2.removeClass('verberg');
        div3.addClass('verberg');
}

function verbergPic3() {
        div1.addClass('verberg');
        div2.addClass('verberg');
        div3.removeClass('verberg');
}
