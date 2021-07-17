"use strict";

var check = function () {
  if (
    document.getElementById("password").value ==
    document.getElementById("confirm_password").value
  ) {
    document.getElementById("message").style.color = "green";
    document.getElementById("message").innerHTML = "Passwords matching";
    document.getElementById("submit-button").disabled = false;
  } else {
    document.getElementById("message").style.color = "red";
    document.getElementById("message").innerHTML = "Passwords are not matching";
    document.getElementById("submit-button").disabled = true;
  }
};

const form = document.getElementsByTagName("form")[0];
const email = document.getElementById("email");
const password = document.getElementById("password");
const button = document.getElementById("submit-button");

email.addEventListener("input", function (event) {
  if (email.validity.valid) {
    document.getElementById("message2").style.color = "green";
    document.getElementById("message2").innerHTML = "Looks good!";
  } else {
    document.getElementById("message2").style.color = "red";
    showEmailError();
  }
});

password.addEventListener("input", function (event) {
  if (password.validity.valid) {
    document.getElementById("message3").style.color = "green";
    document.getElementById("message3").innerHTML = "Looks good!";
  } else {
    document.getElementById("message3").style.color = "red";
    showPasswordError();
  }
});

form.addEventListener("submit", function (event) {
  event.preventDefault();
  if (!email.validity.valid) {
    showEmailError();
  } else if (!password.validity.valid) {
    showPasswordError();
  } else {
    saveAndConfirm();
    alert("Tack för registrering!");
    document.forms[0].reset();
    document.getElementById("message").innerHTML = "";
    document.getElementById("message2").innerHTML = "";
    document.getElementById("message3").innerHTML = "";
  }
});

let fans = [];

const saveAndConfirm = (ev) => {
  let fan = {
    id: Date.now(),
    email: email.value,
    password: password.value,
  };
  fans.push(fan);

  //for display purposes only
  console.log("added", { fans });

  //saving to localStorage
  localStorage.setItem("MyFanList", JSON.stringify(fans));
};

function showEmailError() {
  if (email.validity.valueMissing) {
    document.getElementById("message2").innerHTML =
      "You need to enter an e-mail address.";
  } else if (email.validity.typeMismatch) {
    document.getElementById("message2").innerHTML =
      "Entered value needs to be an e-mail address.";
  } else if (email.validity.tooShort) {
    document.getElementById(
      "message2"
    ).innerHTML = `Email should be at least ${email.minLength} characters; you entered ${email.value.length}.`;
  }
}

function showPasswordError() {
  if (password.validity.valueMissing) {
    document.getElementById("message3").innerHTML =
      "You need to enter a password";
  } else if (password.validity.patternMismatch) {
    document.getElementById("message3").innerHTML =
      "Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters";
  }
}
