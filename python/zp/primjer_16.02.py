import os, platform, logging

if platform.platform().startswith("Windows"):
    log_fajl = os.path.join(os.getenv("HOMEDRIVE"),\
                            os.getenv("HOMEPATH"),\
                            "test.log")
else:
    log_fajl = os.path.join(os.getenv("HOME"), "test.log")

print("Logijem u", log_fajl)

logging.basicConfig(\
    level = logging.DEBUG,\
    format = "%(asctime)s : %(levelname)s : %(message)s",\
    filename = log_fajl,\
    filemode = "w",)

logging.debug("Pocetak programa")
logging.info("Radim nesto")
logging.warning("A sad umirem")
