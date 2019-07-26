"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Customer_1 = require("./Customer");
var c = new Customer_1.Customer(1, "Dhruv", "Ballikar");
console.log(c.ID);
console.log(c.FullName);
var a = new Customer_1.Address(102, "Sheetal nagar", "Mira Road");
console.log(a.Address);
