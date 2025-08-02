$(document).ready(function () {
  var minute = 0;
  var second = 0;
  var msecond = 0;

  $("#stop").click(function () {
    clearInterval(clockInterval);
    $("#start").attr("disabled", false);
  });

  $("#start").click(function () {
    clockInterval = setInterval(clock, 100);
    $("#start").attr("disabled", true);
  });

  $("#reset").click(function () {
    clearInterval(clockInterval);
    minute = 0;
    second = 0;
    msecond = 0;
    $("#clock").text(`${minute}:${second}:${msecond}`);
    $("#start").attr("disabled", false);
  });

  $("#note").click(function () {
    var clock = $("#clock").text();
    const li = document.createElement("li");
    li.innerText = clock;
    $("#setted").append(li);
  });

  function clock() {
    msecond += 1;
    if (msecond === 10) {
      second += 1;
      msecond = 0;
    }
    if (second === 60) {
      minute += 1;
      second = 0;
    }
    $("#clock").text(`${minute}:${second}:${msecond}`);
  }
});
