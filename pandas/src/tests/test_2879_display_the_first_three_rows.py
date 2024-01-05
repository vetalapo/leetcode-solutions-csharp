import sys

# Preventing creation of __pycache__
sys.dont_write_bytecode = True

import importlib
import unittest
import pandas as pd

# Python really doesn't like paths with "-" and "/"
# I don't like Python not liking it so
# have to use importlib to import modules
unit = importlib.import_module("src.2879-display-the-first-three-rows")

input_data = {
    "employee_id": [3, 90, 9, 60, 49, 43],
    "name": ["Bob", "Alice", "Tatiana", "Annabelle", "Jonathan", "Khaled"],
    "department": ["Operations", "Sales", "Engineering", "InformationTechnology", "HumanResources", "Administration"],
    "salary": [48675, 11096, 33805, 37678, 23793, 40454]
}

expected_data = {
    "employee_id": [3, 90, 9],
    "name": ["Bob", "Alice", "Tatiana"],
    "department": ["Operations", "Sales", "Engineering"],
    "salary": [48675, 11096, 33805]
}

input_df = pd.DataFrame(data = input_data)
expected_df = pd.DataFrame(data = expected_data)


class TestDisplayTheFirstThreeRows(unittest.TestCase):
    def test_selectFirstRows(self):
        actual_df = unit.selectFirstRows(input_df)
        self.assertTrue(actual_df.equals(expected_df), "The result should return the first 3 rows")

if __name__ == "__main__":
    unittest.main()
