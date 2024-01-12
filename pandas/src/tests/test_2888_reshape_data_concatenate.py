import sys

# Preventing creation of __pycache__
sys.dont_write_bytecode = True

import importlib
import unittest
import pandas as pd

# Python really doesn't like paths with "-" and "/"
# I don't like Python not liking it so
# have to use importlib to import modules
unit = importlib.import_module("src.2888-reshape-data-concatenate")

df1 = pd.DataFrame({
    "student_id": [1, 2, 3, 4],
    "name": ["Mason", "Ava", "Taylor", "Georgia"],
    "age": [8, 6, 15, 17]
})

df2 = pd.DataFrame({
    "student_id": [5, 6],
    "name": ["Leo", "Alex"],
    "age": [7, 7]
})

expected_df = pd.DataFrame({
    "student_id": [1, 2, 3, 4, 5, 6],
    "name": ["Mason", "Ava", "Taylor", "Georgia", "Leo", "Alex"],
    "age": [8, 6, 15, 17, 7, 7]
})

class TestConcatenateTables(unittest.TestCase):
    def test_concatenateTables(self):
        actual_df = unit.concatenateTables(df1, df2)
        actual_df.reset_index(drop=True, inplace=True)
        
        pd.testing.assert_frame_equal(actual_df, expected_df)

if __name__ == "__main__":
    unittest.main()
