var interval = 1000;

//var y, m, d, h, mt, s
function ShowCountDown(year, month, day, hour, minute, second, divname) {
    var now = new Date();
    var endDate = new Date(year, month, day, hour, minute, second);
    var leftTime = endDate.getTime() - now.getTime();
    var leftsecond = parseInt(leftTime / 1000);
    var day1 = Math.floor(leftsecond / (60 * 60 * 24));
    var hour = Math.floor((leftsecond - day1 * 24 * 60 * 60) / 3600);
    var minute = Math.floor((leftsecond - day1 * 24 * 60 * 60 - hour * 3600) / 60);
    var second = Math.floor(leftsecond - day1 * 24 * 60 * 60 - hour * 3600 - minute * 60);
    var cc = document.getElementById(divname);
    if (day1 < 0)
    {
        cc.innerHTML = "Over " + -1 * day1 + " Days. </br>Please come back soon.";
    }
    else
    {
        cc.innerHTML = day1 + "Days. " + hour + ":" + minute + ":" + second;
    }
}

window.setInterval(function () { ShowCountDown(y, m, d, h, mt, s, 'nextstime'); }, interval);
//window.setInterval(function () { ShowCountDown(y2, m2, d2, 'nextvtime'); }, interval);