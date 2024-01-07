import sys

# Preventing creation of __pycache__
sys.dont_write_bytecode = True

import importlib
import unittest
import pandas as pd

# Python really doesn't like paths with "-" and "/"
# I don't like Python not liking it so
# have to use importlib to import modules
unit = importlib.import_module("src.2884-modify-columns")

input_data = {
    "name": ["Jack", "Piper", "Mia", "Ulysses"],
    "salary": [19666, 74754, 62509, 54866]
}

expected_data = {
    "name": ["Jack", "Piper", "Mia", "Ulysses"],
    "salary": [39332, 149508, 125018, 109732]
}

input_df = pd.DataFrame(data = input_data)
expected_df = pd.DataFrame(data = expected_data)


class TestModifySalary(unittest.TestCase):
    def test_modifySalaryColumn(self):
        actual_df = unit.modifySalaryColumn(input_df)
        self.assertTrue(actual_df.equals(expected_df), "The result should double the salary")

if __name__ == "__main__":
    unittest.main()
