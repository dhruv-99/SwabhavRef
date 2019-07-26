export class Customer {
    constructor(private id: number, private firstName: string, private lastName: string) {

    }

    get ID() {
        return this.id;
    }
    get FullName() {
        return this.firstName + " " + this.lastName;
    }
}

export class Address {
    constructor(private flatNo: number, private street: string, private town: string) {
    }
    get Address() {
        return this.flatNo + " " + this.street + " " + this.town;
    }

}