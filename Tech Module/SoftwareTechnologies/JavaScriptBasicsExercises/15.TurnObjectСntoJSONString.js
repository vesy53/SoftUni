function solve(input) {
    let student = {};

    for (let line of input) {
        let tokens = line.split(' -> ');

        let propName = tokens[0];
        let value = isNaN(tokens[1]) ? tokens[1] : Number(tokens[1]);

        student[propName] = value;
    }

    console.log(JSON.stringify(student));
}