$(document).ready(function(){
    $("#submit").click(function(e){
        e.preventDefault();
        var pass1 = $("#first").val(); 
        var pass2 = $("#second").val(); 
        if(pass1 !== pass2){
            $("#second").css("borderColor", "red");
            $("#error").text("Parollar ust uste dusmur");
        }
        else{
            $("#second").css("borderColor", "#dee2e6");
            $("#error").text("");
        }
    })
});