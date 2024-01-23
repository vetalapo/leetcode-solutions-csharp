const createHelloWorld = require("../2667-create-hello-world-function");

test("Returns a function", () => {
    expect(typeof(createHelloWorld())).toBe("function");
});

test("Empty array", () => {
    expect(createHelloWorld([])()).toBe("Hello World");
});

test("List a few arguments", () => {
    expect(createHelloWorld(1, 2, 3)()).toBe("Hello World");
});

test("No arguments", () => {
    expect(createHelloWorld()()).toBe("Hello World");
});
