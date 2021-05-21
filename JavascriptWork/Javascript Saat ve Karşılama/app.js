const time = document.getElementById("time");
const bar = document.getElementById("bar");
const day = document.getElementById("day");
const text = document.getElementById("name");

function showTime() {
    const date = new Date();
    const getDays = date.getDay();
    let toDay;
    hours = date.getHours();
    minute = date.getMinutes();
    second = date.getSeconds();

    for (i = 1.7; i <= second; i += second) {
        x = i * second;
        bar.style.width = `${x}%`;
    }
    time.innerHTML = `${hours}:${minute}`;

    if (getDays == 1) {
        toDay = "pazartesi";
    }
    if (getDays == 2) {
        toDay = "Salı";
    }
    if (getDays == 3) {
        toDay = "Çarşamba";
    }
    if (getDays == 4) {
        toDay = "Perşembe";
    }
    if (getDays == 5) {
        toDay = "Cuma";
    }
    if (getDays == 6) {
        toDay = "Cumartesi";
    }
    if (getDays == 7) {
        toDay = "Pazar";
    }
    day.innerHTML = `${toDay}`;
    setTimeout(showTime, 1000);

}

function Whatname() {

    let textName = prompt("Adınızı Girin Lütfen", "Kodluyoruz.com");
    if (textName != null) {
        text.innerHTML = `Hoşgeldiniz ${textName}`;
    }
    showTime()
}
Whatname();