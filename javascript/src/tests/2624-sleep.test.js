const sleep = require("../2624-sleep");

test("100 ms delay", async () => {
	let startTime = Date.now()
    
	await sleep(100);
	
	let result = Date.now() - startTime;

    expect(result).toBeGreaterThanOrEqual(100);
    expect(result).toBeLessThanOrEqual(130);
});

test("200 ms delay", async () => {
	let startTime = Date.now()
    
	await sleep(200);
	
	let result = Date.now() - startTime;

	expect(result).toBeGreaterThanOrEqual(200);
    expect(result).toBeLessThanOrEqual(230);
});
