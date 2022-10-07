window.onload = function () {
    document.getElementById('StudentInfo').style.visibility = "hidden";
    document.getElementById('header12').style.visibility = "hidden";
    document.getElementById('Report').setAttribute("id", "report");

}
const DownloadBtn = document.getElementById('Downloadbtn');
DownloadBtn.addEventListener("click", myFunction);

function myFunction() {
    document.getElementById('Downloadbtn').style.visibility = "hidden";
    document.getElementById('btnUp').style.visibility = "hidden"
    document.getElementById('header').style.visibility = "hidden";
    document.getElementById('header12').style.visibility = "visible";
    document.getElementById('report').setAttribute("id", "Report")
    document.getElementById('StudentInfo').style.visibility = "visible";
    window.print();
    document.getElementById('StudentInfo').style.visibility = "hidden";
    document.getElementById('header').style.visibility = "visible";
    document.getElementById('btnUp').style.visibility = "visible"
    document.getElementById('Downloadbtn').style.visibility = "visible";
    document.getElementById('header12').style.visibility = "hidden";
    document.getElementById('Report').setAttribute("id", "report");


}

