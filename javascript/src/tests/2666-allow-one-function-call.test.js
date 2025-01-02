const once = require("../2666-allow-one-function-call");

test("is function", async () => {
    const fn = (a, b) => a + b;
    const onceFn = once(fn);
    
    expect(typeof onceFn).toBe("function");
});

test("2 calls", async () => {
    const fn = (a, b, c) => a + b + c;
    const onceFn = once(fn);

    expect(onceFn(1, 2, 3)).toEqual(6);
    expect(onceFn(2, 3, 6)).toBe(undefined);
});

test("3 calls", async () => {
    const fn = (a, b, c) => a * b * c;
    const onceFn = once(fn);

    expect(onceFn(5, 7, 4)).toEqual(140);
    expect(onceFn(2, 3, 6)).toBe(undefined);
    expect(onceFn(4, 6, 8)).toBe(undefined);
});
