function solve(arr) {
    let n = Number(arr[0]);
    let result = new Array(n).fill(0);

    for (let i = 1; i < arr.length; i++) {
        let num = arr[i].split(' - ').map(Number);

        let index = num[0];
        let value = num[1];

        result[index] = value;
    }

    console.log(result.join('\n'));
}