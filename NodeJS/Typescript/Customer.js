"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Customer = /** @class */ (function () {
    function Customer(id, firstName, lastName) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
    }
    Object.defineProperty(Customer.prototype, "ID", {
        get: function () {
            return this.id;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Customer.prototype, "FullName", {
        get: function () {
            return this.firstName + " " + this.lastName;
        },
        enumerable: true,
        configurable: true
    });
    return Customer;
}());
exports.Customer = Customer;
var Address = /** @class */ (function () {
    function Address(flatNo, street, town) {
        this.flatNo = flatNo;
        this.street = street;
        this.town = town;
    }
    Object.defineProperty(Address.prototype, "Address", {
        get: function () {
            return this.flatNo + " " + this.street + " " + this.town;
        },
        enumerable: true,
        configurable: true
    });
    return Address;
}());
exports.Address = Address;
