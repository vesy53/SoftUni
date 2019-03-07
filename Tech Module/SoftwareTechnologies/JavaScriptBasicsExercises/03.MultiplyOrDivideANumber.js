function multiplyDivideANumber(arr) {
    let firstNum = Number(arr[0]);
    let secondNum = Number(arr[1]);
    let result;

    if(firstNum <= secondNum){
        result = firstNum * secondNum;
    }
    else if(firstNum > secondNum){
        result = firstNum / secondNum;
    }

    console.log(result);
}