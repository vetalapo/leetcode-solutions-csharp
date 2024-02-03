const filter = require("../2634-filter-elements-from-array");

test("Filter greater than 10 function", async () => {
    const inputArray = [0, 10, 20, 30];
    const greaterThan10 = (n) => n > 10;
    const result = filter(inputArray, greaterThan10);

    expect(result).toStrictEqual([20, 30]);
});

test("Filter first index", async () => {
    const inputArray = [1, 2, 3];
    const firstIndex = (_, i) => i === 0;
    const result = filter(inputArray, firstIndex);

    expect(result).toStrictEqual([1]);
});

test("Filter and plus one", async () => {
    const inputArray = [-2, -1, 0, 1, 2];
    const plusOne = (n) => n + 1;
    const result = filter(inputArray, plusOne);

    expect(result).toStrictEqual([-2, 0, 1, 2]);
});
