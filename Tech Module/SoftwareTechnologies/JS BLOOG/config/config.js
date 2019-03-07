const path = require('path');

module.exports = {
    rootFolder: path.normalize(path.join(__dirname, '/../')),//'/../'-начален константен път тъй като сме внепрекъснато скачане от файл на файл
    database:{
        "development": {
            "username": "root",
            "password": null,
            "database": "blog", //от тук взимаме базата данни
            "host": "127.0.0.1",
            "dialect": "mysql",
            "logging": false
        },
    }
};

