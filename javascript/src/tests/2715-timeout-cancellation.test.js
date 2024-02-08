const cancellable = require("../2715-timeout-cancellation");

jest.useFakeTimers();
jest.spyOn(global, "setTimeout");

test("Returns a function", async () => {
    const fn = (x) => x * 5;
    const args = [2];
    const t = 20;

    expect(typeof cancellable(fn, args, t)).toBe("function");
});

test("Passed function with timers", async () => {
    const result = [];
  
    const fn = (x) => x * 5;
    const args = [2];
    const t = 20;

    const cancelTimeMs = 50;
    const start = performance.now();
  
    const log = (...argsArr) => {
        const diff = Math.floor(performance.now() - start);
        result.push({"time": diff, "returned": fn(...argsArr)});
    }

    const cancel = cancellable(log, args, t);
    const maxT = Math.max(t, cancelTimeMs);
             
    setTimeout(cancel, cancelTimeMs);
  
    setTimeout(() => {
        expect(result).toStrictEqual([{"time": 20,"returned": 10}]);
    }, maxT + 15);
});
