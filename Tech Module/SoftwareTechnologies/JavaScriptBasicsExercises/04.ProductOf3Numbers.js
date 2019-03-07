function productOf3Numbers(arr) {
    let firstNum = Number(arr[0]);
    let secondNum = Number(arr[1]);
    let thirdNum = Number(arr[2]);
    let counter = 0;

    if(firstNum == 0 || secondNum == 0 || thirdNum == 0){
        console.log("Positive");
        return;
    }

    if(firstNum < 0){
        counter++;
    }
    if(secondNum < 0){
        counter++;
    }
    if(thirdNum < 0){
        counter++;
    }

    if(counter % 2 == 1){
        console.log("Negative");
    }
    else{
        console.log("Positive");
    }
}