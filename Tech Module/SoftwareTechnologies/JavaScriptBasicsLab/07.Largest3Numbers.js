function largest3Numbers(input){
    let arr = input.map(Number);
    let arrSorted = arr.sort((a, b) => b - a);
    let count  = Math.min(3, input.length);

    for (let i = 0; i < count; i++) {
        console.log(arrSorted[i]);
    }
}