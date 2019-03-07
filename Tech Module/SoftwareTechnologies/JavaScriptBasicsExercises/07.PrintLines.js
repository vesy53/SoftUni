function solve(arr) {
    let command = arr;

    for (let comm of command) {
        if(comm != "Stop") {
            console.log(comm);
        }else {
            break;
        }
    }
}