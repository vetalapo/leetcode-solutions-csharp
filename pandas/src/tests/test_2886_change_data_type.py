import sys

# Preventing creation of __pycache__
sys.dont_write_bytecode = True

import importlib
import unittest
import pandas as pd

# Python really doesn't like paths with "-" and "/"
# I don't like Python not liking it so
# have to use importlib to import modules
unit = importlib.import_module("src.2886-change-data-type")

df = pd.DataFrame({
    "student_id": [1, 2],
    "name": ["Ava", "Kate"],
    "age": [6, 15],
    "grade": [73.0, 87.5]
})

expected_df = pd.DataFrame({
    "student_id": [1, 2],
    "name": ["Ava", "Kate"],
    "age": [6, 15],
    "grade": [73, 87]
})

class TestChangeDatatype(unittest.TestCase):
    def test_changeDatatype(self):
        expected_df.grade = expected_df.grade.astype(int)
        actual_df = unit.changeDatatype(df)
        
        pd.testing.assert_frame_equal(actual_df, expected_df)

if __name__ == "__main__":
    unittest.main()
