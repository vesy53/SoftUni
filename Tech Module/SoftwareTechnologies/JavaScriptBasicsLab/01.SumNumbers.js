function sumNumbers() {
    let num1 = Number(document.getElementById("num1").value);
    let num2 = Number(document.getElementById("num2").value);

    document.getElementById('result').textContent = num1 + num2;
}