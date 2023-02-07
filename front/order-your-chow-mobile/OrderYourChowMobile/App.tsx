import React from 'react';
import {NavigationContainer} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';
import DietScreen from './screens/DietScreen';
import {store} from './store';
import {Provider} from 'react-redux';
import RecipeScreen from './screens/RecipeScreen';
import {RootStackParamList} from './RootStackParamList';

declare global {
  namespace ReactNavigation {
    interface RootParamList extends RootStackParamList {}
  }
}
const Stack = createNativeStackNavigator();

function App(): JSX.Element {
  return (
    <NavigationContainer>
      <Provider store={store}>
        <Stack.Navigator>
          <Stack.Screen name="Diet" component={DietScreen} />
          <Stack.Screen name="Recipe" component={RecipeScreen} />
        </Stack.Navigator>
      </Provider>
    </NavigationContainer>
  );
}
export default App;
