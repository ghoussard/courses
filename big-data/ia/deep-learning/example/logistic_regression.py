import numpy as np

def create_data():
	nb_row = 5

	sick_people = np.random.randn(nb_row, 2) + np.array([-2, -2])
	healthy_people = np.random.randn(nb_row, 2) + np.array([2, 2])

	inputs = np.vstack([sick_people, healthy_people])
	targets = np.concatenate((np.zeros(nb_row), np.zeros(nb_row)+1))
	
	return inputs, targets

def pre_activation(inputs):
	b = 0
	w = np.random.normal(size=2)
	z = np.dot(inputs, w)
	return z + b

def sigmoid(x):
  return 1 / (1 + np.exp(-x))

if __name__ == '__main__':
	inputs, targets = create_data()
	print(inputs)
	print(targets)

	print('pre_activation')
	preact_array = pre_activation(inputs)
	print(preact_array)

	print('activation')
	act_array = sigmoid(preact_array)
	print(act_array)

	pass
