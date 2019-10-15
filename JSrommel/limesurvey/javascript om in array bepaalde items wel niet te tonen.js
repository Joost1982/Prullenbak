<script type='text/javascript'>

//voorliggend script toont items wel of niet in een array gebaseerd op de scores van een voorgaande array.
//alleen de twee items met de hoogste score worden getoond (van de in totaal vier items
//
//werkwijze: 
//maak een vragenlijst in limesurvey met 2 array-vragen (zelfde aantal items, dubbele / enkele schaal verschil maakt niet uit)
//zet voorliggende script in de source van de tweede array-vraag.


$(document).ready ( function(){ //pas runnen als complete pagina is geladen
  console.log("start check");

  //verzamel alle waarden van vorige vraag '_0' = 1e schaal)
  var item1 = "{q1_SQ001_0.NAOK}" //a
  var item2 = "{q1_SQ002_0.NAOK}" //b
  var item3 = "{q1_SQ003_0.NAOK}" //c
  var item4 = "{q1_SQ004_0.NAOK}" //d

  // voeg toe aan html-stukje waar de vraag staat (als check)
  $( '#ls-question-text-973985X460X3822' ).append('<br><br>value item 1: ');
  $( '#ls-question-text-973985X460X3822' ).append(item1);  
  $( '#ls-question-text-973985X460X3822' ).append('<br>value item 2: ');
  $( '#ls-question-text-973985X460X3822' ).append(item2);  
  $( '#ls-question-text-973985X460X3822' ).append('<br>value item 3: ');
  $( '#ls-question-text-973985X460X3822' ).append(item3);  
  $( '#ls-question-text-973985X460X3822' ).append('<br>value item 4: ');
  $( '#ls-question-text-973985X460X3822' ).append(item4);

    //maak lijst / array
    var items = ['item1', 'item2', 'item3', 'item4'];
    var scores = [item1, item2, item3, item4];

    // voeg toe aan html-stukje waar de vraag staat (als check)
    $( '#ls-question-text-973985X460X3822' ).append('<br><br>itemlijst:<br>');
    $( '#ls-question-text-973985X460X3822' ).append(items);
    $( '#ls-question-text-973985X460X3822' ).append('<br><br>scorelijst:<br>');
    $( '#ls-question-text-973985X460X3822' ).append(scores);  
  
/////////////////////////////////////////////////////////////////////////////////////////

    //////////////////// Manier 1.
    /////////////////// ZIP, SORTEER EN HAAL WEER UIT ELKAAR
   ///// Ik kies uiteindelijk manier 2.
   ////  Laat het even staan, misschien later toch nodig...
   ///
   //zip
   var samengevoegd = [];
   for (var j = 0; j < items.length; j++) 
    samengevoegd.push( { 'item': items[j], 'score': scores[j] } );
   //sorteer:
   var samengevoegdGesorteerd = samengevoegd.slice();
   samengevoegdGesorteerd.sort(function(a, b) {
   return ((a.score < b.score) ? -1 : ((a.score == b.score) ? 0 : 1));
   });
   //weer uit elkaar halen:
    for (var k = 0; k < samengevoegdGesorteerd.length; k++) {
    items[k] = samengevoegdGesorteerd[k].item;
    scores[k] = samengevoegdGesorteerd[k].score;
    }

  //voeg toe aan html-stukje waar de vraag staat (als check)
  $( '#ls-question-text-973985X460X3822' ).append('<br><br>gesorteerde itemlijst:<br>');
  $( '#ls-question-text-973985X460X3822' ).append(items);
  $( '#ls-question-text-973985X460X3822' ).append('<br><br>gesorteerde scorelijst:<br>');
  $( '#ls-question-text-973985X460X3822' ).append(scores); 
  //debug
  console.log(samengevoegd);
  console.log(samengevoegdGesorteerd);

  var onderkant = items.slice(0,2); // maak lijstje van items met 2 laagste scores
  // deze lijst wordt vervolgens gebruikt om items wel of niet te tonen in de uiteindelijke array
  // probleem is echter dat je nu altijd dezelfde items krijgt bij gelijke scores
  // (als je bij a,b,c,d 1 invult, verdwijnen altijd 'a' en 'b' in de array)
  // daarom heb ik hieronder een tweede manier gecode.

/////////////////////////////////////////////////////////////////////////////////////////

    //////////////////// Manier 2.

    //we gaan items met dezelfde score randomizen
    //zodat niet steeds dezelfde items worden getoond / verwijderd

    
    ///// begin shuffle functie ///////////////////
    //bron: https://stackoverflow.com/questions/2450954/how-to-randomize-shuffle-a-javascript-array
    function shuffle(array) {
      var currentIndex = array.length, temporaryValue, randomIndex;

      // While there remain elements to shuffle...
      while (0 !== currentIndex) {

      // Pick a remaining element...
      randomIndex = Math.floor(Math.random() * currentIndex);
      currentIndex -= 1;
      // And swap it with the current element.
      temporaryValue = array[currentIndex];
      array[currentIndex] = array[randomIndex];
      array[randomIndex] = temporaryValue;
      }

      return array;
    }
  ///// einde shuffle functie ///////////////////
    
    //score 1
    var items_score1 = []
    var scores_score1 = []
    for (var k = 0; k < scores.length; k++) {
      if (scores[k] == 1) {
            scores_score1.push(1);
            items_score1.push(items[k])
          };
    };    
    items_score1 = shuffle(items_score1);
    
    //score 2
    var items_score2 = []
    var scores_score2 = []
    for (var k = 0; k < scores.length; k++) {
      if (scores[k] == 2) {
            scores_score2.push(2);
            items_score2.push(items[k])
          };
    };    
    items_score2 = shuffle(items_score2);

    //score 3
    var items_score3 = []
    var scores_score3 = []
    for (var k = 0; k < scores.length; k++) {
      if (scores[k] == 3) {
            scores_score3.push(3);
            items_score3.push(items[k])
          };
    };    
    items_score3 = shuffle(items_score3);

    //score 4
    var items_score4 = []
    var scores_score4 = []
    for (var k = 0; k < scores.length; k++) {
      if (scores[k] == 4) {
            scores_score4.push(1);
            items_score4.push(items[k])
          };
    };    
    items_score4 = shuffle(items_score4);
  
     //score 5 
    var items_score5 = []
    var scores_score5 = []
    for (var k = 0; k < scores.length; k++) {
      if (scores[k] == 5) {
            scores_score5.push(5);
            items_score5.push(items[k])
          };
    };    
    items_score5 = shuffle(items_score5);

  //samenvoegen en slicen (onderste 2 worden straks niet getoond)
  var items = items_score1.concat(items_score2, items_score3, items_score4, items_score5);
  var onderkant = items.slice(0,2); 
  //ditmaal zijn de onderste twee dus random bij gelijke scores
  //(als je bij a,b,c,d 1 invult, verdwijnen niet altijd 'a' en 'b' in de array)

  //debug
  console.log(scores_score1);
  console.log(items_score1);
  console.log(scores_score2);
  console.log(items_score2);
  console.log(scores_score3);
  console.log(items_score3);
  console.log(scores_score4);
  console.log(items_score4);
  console.log(scores_score5);
  console.log(items_score5);

/////////////////////////////////////////////////////////////////////////////////////////

  // Toon of toon element niet, gebaseerd op de scores
  
  if(onderkant.includes('item1') == true) {
       //gewoon javascript
       //document.getElementById("javatbd973985X460X3822SQ001").style.display = "none";
       //in jquery
      $("#javatbd973985X460X3822SQ001").css("display","none");        
       }
  if(onderkant.includes('item2') == true) {
      $("#javatbd973985X460X3822SQ002").css("display","none");
       }
  if(onderkant.includes('item3') == true) {
      $("#javatbd973985X460X3822SQ003").css("display","none");
       }
  if(onderkant.includes('item4') == true) {
      $("#javatbd973985X460X3822SQ004").css("display","none");
       }

  console.log("einde check");
  
});
</script>