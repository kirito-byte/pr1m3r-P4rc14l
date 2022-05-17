swipath = 'C:\\Program Files\\swipl\\bin'
import os
os.environ['PATH'] = swipath + os.pathsep + os.environ['PATH']

from pyswip import Prolog
prolog = Prolog()
prolog.assertz("abuelo(jose,samuel)")
prolog.assertz("abuelo(jose,joel)")
prolog.assertz("abuelo(jose,debra)")

#list(prolog.query("abuelo(jose,X)")) == [{'X': 'samuel'}, {'X': 'joel'}, {'X': 'debra'}]

prolog.assertz("nieto(samuel,jose)")
prolog.assertz("nieto(joel,jose)")
prolog.assertz("nieto(debra,jose)")

prolog.assertz("primo(samuel,saul)")
prolog.assertz("primo(samuel,natalia)")
prolog.assertz("primo(samuel,cesar)")
#list(prolog.query("abuelo(jose,X)")) == [{'X': 'samuel'}, {'X': 'joel'}, {'X': 'debra'}]
for persona in prolog.query("abuelo(X,Y)"):
    print(persona["X"], "es abuelo de: ", persona["Y"])

for persona in prolog.query("nieto(X,Y)"):
    print(persona["X"], "es nieto de: ", persona["Y"])

for persona in prolog.query("primo(X,Y)"):
    print(persona["X"], "es primo de: ", persona["Y"])