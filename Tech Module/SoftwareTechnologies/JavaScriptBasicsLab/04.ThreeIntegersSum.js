function threeIntegersSum(inputArr) {
    let arr = inputArr[0].split(' ');
    let num = Number(arr[0]);
    let num1 = Number(arr[1]);
    let num2 = Number(arr[2]);

    let result;
    if(num + num1 == num2) {
        result = `${Math.min(num, num1)} + ${Math.max(num, num1)} = ${num2}`;
    }
    else if(num1 + num2 == num) {
        result = `${Math.min(num1, num2)} + ${Math.max(num1, num2)} = ${num}`;
    }
    else if(num + num2 == num1) {
        result = `${Math.min(num, num2)} + ${Math.max(num, num2)} = ${num1}`;
    }
    else {
        result = "No";
    }

    console.log(result);
}