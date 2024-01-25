import sys

# Preventing creation of __pycache__
sys.dont_write_bytecode = True

import importlib
import unittest
import pandas as pd

# Python really doesn't like paths with "-" and "/"
# I don't like Python not liking it so
# have to use importlib to import modules
unit = importlib.import_module("src.2877-create-a-dataframe-from-list")

input_data = [[1, 15], [2, 11], [3, 11], [4, 20]]

expected_df = pd.DataFrame(data = {
    "student_id": [1, 2, 3, 4],
    "age": [15, 11, 11, 20]
})

class TestDisplayTheFirstThreeRows(unittest.TestCase):
    def test_createDataframe(self):
        actual_df = unit.createDataframe(input_data)
        self.assertTrue(actual_df.equals(expected_df), "The result should return the list converted to pandas data frame")

if __name__ == "__main__":
    unittest.main()
