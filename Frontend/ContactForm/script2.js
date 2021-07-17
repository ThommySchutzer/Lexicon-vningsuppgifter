"use strict";

const form2 = document.getElementsByTagName("form")[0];
const email = document.getElementById("email2");
const password = document.getElementById("password2");
const button = document.getElementById("submit-button2");

let fan = {
  id: "093467",
  email: "ghj@dfgh",
  password: "45RTfghj",
};

let fans = JSON.parse(localStorage.MyFanList);
fan = fans[0];

console.log(fans[0].id, fans[0].email, fans[0].password);
console.log(fan);

form2.addEventListener("submit", function (event) {
  event.preventDefault();
  if (email.validity.valid && password.validity.valid) {
    // lookup
    if (email.value == fans[0].email && password.value == fans[0].password) {
      alert("Nu är du inloggad!");
      document.forms[0].reset();
      document.getElementById("message4").innerHTML = "";
      document.getElementById("message5").innerHTML = "";
    }
    // Gör nåt
  } else {
    if (!email2.validity.valid) {
      document.getElementById("message4").style.color = "red";
      showEmail2Error();
    }
    if (email2.validity.valid) {
      document.getElementById("message4").style.color = "green";
      document.getElementById("message4").innerHTML = "Looks good!";
    }
    if (!password2.validity.valid) {
      document.getElementById("message5").style.color = "red";
      showPassword2Error();
    }
    if (password2.validity.valid) {
      document.getElementById("message5").style.color = "green";
      document.getElementById("message5").innerHTML = "Looks good!";
    }
  }
});

function showEmail2Error() {
  if (email.validity.valueMissing) {
    document.getElementById("message4").innerHTML =
      "You need to enter an e-mail address.";
  } else if (email.validity.typeMismatch) {
    document.getElementById("message4").innerHTML =
      "Entered value needs to be an e-mail address.";
  }
}

function showPassword2Error() {
  if (password.validity.valueMissing) {
    document.getElementById("message5").innerHTML =
      "You need to enter a password";
  }
}
