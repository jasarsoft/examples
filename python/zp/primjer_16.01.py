import sys, warnings

if sys.version_info.major < 3:
    warnings.warn("Potreban vam je Python 3.0 da bi pokrenui ovaj program", RuntimeWarning)
else:
    print("Nastaviti normalno")
