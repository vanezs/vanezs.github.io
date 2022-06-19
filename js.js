var quoteArray = [];
var index = 0;
var textPosition = 0;
var flag = true;
var destination = document.getElementById("typedtext")

window.addEventListener('load', typewriter);

function loadQuote()
{
    const url="https://api.quotable.io/random";

    fetch(url)

    .then(Response =>{
        if(Response.ok)
            return Response.json();
        else
            console.log(Response.status);
    })

    .then(data => {
        quoteArray[index] = data.content;
    })
}

function typewriter()
{
    if(flag)
    {
        loadQuote();
        quoteArray[index] += ' ';
        flag = false;
    }

    destination.innerHTML = quoteArray[index].substring(0, textPosition) + '<span>\u25AE<span>';

    if(textPosition++ != quoteArray[index].length){
        setTimeout('typewriter()', 100);
    }
    else
    {
        quoteArray[index] = " ";
        setTimeout('typewriter()', 3000);
        textPosition = 0;
        flag = true;
    }
}

function writeTextByJS(id, text, speed){

    var ele = document.getElementById(id),
      txt = text.join("").split("");

  var interval = setInterval(function(){

      if(!txt[0]){

            return clearInterval(interval);
     };

      ele.innerHTML += txt.shift();
   }, speed != undefined ? speed : 100);

   return false;
};
 
typewriter();
writeTextByJS(
    "demo",
     [
         "Первая строка\n",
         "Вторая строка\n"
      ]
  );
