const Sequelize = require('sequelize');

module.exports = function(sequelize) {
    const Article = sequelize.define('Article', {
        title: {
            type: Sequelize.STRING,
            allowNull: false,
            required: true
        },
        imageUrl: {
            type: Sequelize.STRING,
            allowNull: false,
            required: true
        },
        summary: {
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        content: {
            type: Sequelize.TEXT,
            allowNull: false,
            required: true
        },
        date: {
            type: Sequelize.DATE,
            allowNull: false,
            required: true,
            defaultValue: Sequelize.NOW //слагаме тек. дата
        },
    });
    /*associate - сътрудник, НЕЩО СВЪРЗАНО С ДРУГО
    belongsTo - принадлежи на
    foreignKey - чуждестранен(външен) ключ
    targetKey - целеви ключ
     */
    Article.associate = function (models) {
        Article.belongsTo(models.User, {
            foreignKey: 'authorId',
            targetKey: 'id'
        });
    };

    return Article;
};