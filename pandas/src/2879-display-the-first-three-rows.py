import sys

# Preventing creation of __pycache__
sys.dont_write_bytecode = True

import pandas as pd

def selectFirstRows(employees: pd.DataFrame) -> pd.DataFrame:
    return employees.head(3)
