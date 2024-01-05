const argumentsLength = require("../2703-return-length-of-arguments-passed");

test("Empty array", () => {
    expect(argumentsLength([])).toBe(1);
});

test("List a few arguments", () => {
    expect(argumentsLength(1, 2, 3)).toBe(3);
});

test("Single argument, array with one item", () => {
    expect(argumentsLength([5])).toBe(1);
});

test("Single argument, array with a few items", () => {
    expect(argumentsLength([5])).toBe(1);
});

test("No arguments", () => {
    expect(argumentsLength()).toBe(0);
});
