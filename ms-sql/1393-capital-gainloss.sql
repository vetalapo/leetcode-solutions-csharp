/**
 * 1393
 * Capital Gain/Loss
 **
 * Write a solution to report the Capital gain/loss for each stock.
 * The Capital gain/loss of a stock is the total gain or loss after buying and selling the stock one or many times.
 * Return the result table in any order.
 *
 * +---------------+---------+
 * | Column Name   | Type    |
 * +---------------+---------+
 * | stock_name    | varchar |
 * | operation     | enum    |
 * | operation_day | int     |
 * | price         | int     |
 * +---------------+---------+
 *
 * (stock_name, operation_day) is the primary key (combination of columns with unique values) for this table.
 * The operation column is an ENUM (category) of type ('Sell', 'Buy')
 * Each row of this table indicates that the stock which has stock_name had an operation on the day operation_day with the price.
 *
 * It is guaranteed that each 'Sell' operation for a stock has a corresponding 'Buy' operation in a previous day.
 * It is also guaranteed that each 'Buy' operation for a stock has a corresponding 'Sell' operation in an upcoming day.
 *
 * Output:
 * +---------------+-------------------+
 * | stock_name    | capital_gain_loss |
 * +---------------+-------------------+
 * | Corona Masks  | 9500              |
 * | Leetcode      | 8000              |
 * | Handbags      | -23000            |
 * +---------------+-------------------+
 *
 * https://leetcode.com/problems/capital-gainloss/
 */
 
SELECT 
  stock_name,
  SUM(
    CASE
      WHEN operation = 'Buy' THEN -price
      WHEN operation = 'Sell' THEN price
    END
  ) AS capital_gain_loss
FROM Stocks
GROUP BY stock_name;
