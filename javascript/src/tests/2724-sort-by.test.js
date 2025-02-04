const sortBy = require("../2724-sort-by");

test("Asc sort", async () => {
    const inputArr = [5, 4, 1, 2, 3];
    const sortFunction = (x) => x;

    const result = sortBy(inputArr, sortFunction);

    expect(result).toStrictEqual([1, 2, 3, 4, 5]);
});

test("Array of objects, sorted by property", async () => {
    const inputArr = [{"x":1}, {"x": 0}, {"x": -1}];
    const sortFunction = (x) => x.x;

    const result = sortBy(inputArr, sortFunction);

    expect(result).toStrictEqual([{"x":-1}, {"x":0}, {"x":1}]);
});

test("Array of arrays, sorted by element index", async () => {
    const inputArr = [[3,4], [5,2], [10,1]];
    const sortFunction = (x) => x[1];

    const result = sortBy(inputArr, sortFunction);

    expect(result).toStrictEqual([[10,1], [5,2], [3,4]]);
});
