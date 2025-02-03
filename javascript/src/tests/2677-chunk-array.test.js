const chunk = require("../2677-chunk-array");

test("Each element is a chunk", async () => {
    const inputArr = [1,2,3,4,5];
    const size = 1;

    const result = chunk(inputArr, size);

    expect(result).toStrictEqual([[1],[2],[3],[4],[5]]);
});

test("Uneven chunks", async () => {
    const inputArr = [1,9,6,3,2];
    const size = 3;

    const result = chunk(inputArr, size);

    expect(result).toStrictEqual([[1,9,6],[3,2]]);
});

test("Chunk is bigger than the size of an array", async () => {
    const inputArr = [8,5,3,2,6];
    const size = 6;

    const result = chunk(inputArr, size);

    expect(result).toStrictEqual([[8,5,3,2,6]]);
});

test("Empty input array should produce empty array as a result", async () => {
    const inputArr = [];
    const size = 1;

    const result = chunk(inputArr, size);

    expect(result).toStrictEqual([]);
});
