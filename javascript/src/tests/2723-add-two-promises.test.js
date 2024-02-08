const addTwoPromises = require("../2723-add-two-promises");

test("Two promises 2 + 5", async () => {
    let promise1 = new Promise(resolve => setTimeout(() => resolve(2), 20));
    let promise2 = new Promise(resolve => setTimeout(() => resolve(5), 60));

    const result = await addTwoPromises(promise1, promise2);

    expect(result).toBe(7);
});

test("Two promises 10 + -12", async () => {
    let promise1 = new Promise(resolve => setTimeout(() => resolve(10), 50));
    let promise2 = new Promise(resolve => setTimeout(() => resolve(-12), 30));

    const result = await addTwoPromises(promise1, promise2);

    expect(result).toBe(-2);
});
