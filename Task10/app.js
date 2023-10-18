class Product {
    constructor(name, price, rating) {
        this.name = name;
        this.price = price;
        this.rating = rating;
    }
}

class Category {
    constructor(name) {
        this.name = name;
        this.products = [];
    }

    addProduct(product) {
        this.products.push(product);
    }
}

class Basket {
    constructor() {
        this.items = [];
    }

    addProduct(product) {
        this.items.push(product);
    }
}

class User {
    constructor(login, password) {
        this.login = login;
        this.password = password;
        this.basket = new Basket();
    }
}

// Создание объектов продуктов
const product1 = new Product("Laptop", 1000, 4.5);
const product2 = new Product("Smartphone", 500, 4.0);
const product3 = new Product("Headphones", 100, 4.2);

// Создание объектов категорий и добавление продуктов
const category1 = new Category("Electronics");
category1.addProduct(product1);
category1.addProduct(product2);

const category2 = new Category("Accessories");
category2.addProduct(product3);

// Создание объектов пользователя и добавление товаров в корзину
const user1 = new User("user1", "password1");
user1.basket.addProduct(product1);
user1.basket.addProduct(product3);

const user2 = new User("user2", "password2");
user2.basket.addProduct(product2);

// Вывод каталога продуктов
console.log("Catalog:");
console.log("Category: " + category1.name);
category1.products.forEach(product => {
    console.log(`  ${product.name} - $${product.price} - Rating: ${product.rating}`);
});

console.log("Category: " + category2.name);
category2.products.forEach(product => {
    console.log(`  ${product.name} - $${product.price} - Rating: ${product.rating}`);
});

// Вывод покупок посетителей магазина
console.log("\nPurchases:");
console.log(`User: ${user1.login}`);
user1.basket.items.forEach(product => {
    console.log(`  ${product.name} - $${product.price}`);
});

console.log(`User: ${user2.login}`);
user2.basket.items.forEach(product => {
    console.log(`  ${product.name} - $${product.price}`);
});
