const ArrayWrapper = require("../2695-array-wrapper");

test("Add two wrappers together", async () => {
    const obj1 = new ArrayWrapper([1, 2]);
    const obj2 = new ArrayWrapper([3, 4]);

    expect(obj1 + obj2).toEqual(10);
    expect(String(obj1)).toEqual("[1,2]");
    expect(String(obj2)).toEqual("[3,4]");
});

test("Wrapper forms the right string format", async () => {
    const obj = new ArrayWrapper([23, 98, 42, 70]);

    expect(String(obj)).toEqual("[23,98,42,70]");
});

test("Empty arrays in input", async () => {
	const obj1 = new ArrayWrapper([]);
	const obj2 = new ArrayWrapper([]);

	expect(obj1 + obj2).toEqual(0);
});
