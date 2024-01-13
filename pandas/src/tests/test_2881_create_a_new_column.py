import sys

# Preventing creation of __pycache__
sys.dont_write_bytecode = True

import importlib
import unittest
import pandas as pd

# Python really doesn't like paths with "-" and "/"
# I don't like Python not liking it so
# have to use importlib to import modules
unit = importlib.import_module("src.2881-create-a-new-column")

sample_df = pd.DataFrame({
    "name": ["Piper", "Grace", "Georgia", "Willow", "Finn", "Thomas"],
    "salary": [4548, 28150, 1103, 6593, 74576, 24433]
})

expected_df = pd.DataFrame({
    "name": ["Piper", "Grace", "Georgia", "Willow", "Finn", "Thomas"],
    "salary": [4548, 28150, 1103, 6593, 74576, 24433],
    "bonus": [9096, 56300, 2206, 13186, 149152, 48866]
})

class TestCreateBonusColumn(unittest.TestCase):
    def test_createBonusColumn(self):
        actual_df = unit.createBonusColumn(sample_df)
        
        pd.testing.assert_frame_equal(actual_df, expected_df)

if __name__ == "__main__":
    unittest.main()
