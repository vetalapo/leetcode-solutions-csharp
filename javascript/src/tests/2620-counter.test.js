const createCounter = require("../2620-counter");

test("Returns a function", () => {
    expect(typeof(createCounter())).toBe("function");
});

test("Positive input", () => {
    let counter = createCounter(10);
    
    counter();
    counter();

    expect(counter()).toBe(12);
});

test("Negative input", () => {
    let counter = createCounter(-2);
    
    counter();
    counter();
    counter();
    counter();

    expect(counter()).toBe(2);
});
