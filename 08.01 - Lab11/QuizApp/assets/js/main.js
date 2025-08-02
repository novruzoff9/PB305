$(document).ready(function () {
  $("#submit").click(function (e) {
    e.preventDefault();
    var trueanswers = [];
    var selecteds = [];
    var input = $("input[type=radio]:checked");
    var duzgunsayi = 0;
    
    input.each(function(index, element) {
        selecteds.push($(element).val());
    });
    
    input.each(function(index, element) {
        trueanswers.push($(element).parents(".question").attr("data-true"));
    });

    console.log("Seçilən cavablar:", selecteds);
    console.log("Dogru cavablar:", trueanswers);

    for (let index = 0; index < selecteds.length; index++) {
        const selected = selecteds[index];
        const trueInd = trueanswers[index];
        if(selected === trueInd){
            duzgunsayi+=1;
        }
    }
    
    alert("duzgun cavab sayi: " + duzgunsayi)
  });
});
