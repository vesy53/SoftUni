const Product = require('../models').Product;

module.exports = {
	index: (req, res) => {
		Product.findAll().then(entries => {
			res.render('product/index', {'entries': entries});
		})
	},

	createGet: (req, res) => {
		res.render('product/create');
	},

	createPost: (req, res) => {
		let args = req.body;
		//console.log(args);
		Product.create(args).then(() => {
			res.redirect("/");
		})
	},

	editGet: (req, res) => {
		let id = req.params.id;
		Product
			.findById(id)
			.then(product => {
				res.render("product/edit", /*{
					"id":product.id,
					"priority":product.priority,
					"name":product.name,
					"quantity":product.quantity,
					"status":product.status
                }*/product.dataValues);
		})
	},

	editPost: (req, res) => {
		let id = req.params.id;
		let args = req.body;

		Product.findById(id).then(product => {
            product.updateAttributes(args).then(()=> {
				res.redirect("/");
		/*	product.id = id;
			product.priority = args.priority;
			product.quantity = args.quantity;
            product.name = args.name;
            product.status = args.status;

            product.save().then(() => {
				res.redirect('/');*/
			});
		})
	},

	deleteGet: (req, res) => {
        let id = req.params.id;

        Product.findById(id).then(product => {
            res.render("product/delete", product.dataValues);
        })
    },

	deletePost: (req, res) => {
		 let id = req.params.id;
		/*First method
		 Product.findById(id).then(product => {
			 return	product.destroy();
         }).then(success => {
         	res.redirect("/");
		 })*/

		//Second method
		Product.findById(id).then(product => {
			product.destroy().then(() => {
				res.redirect("/");
			})
		})
	},
};