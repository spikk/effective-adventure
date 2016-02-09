package entityAccess.eao;

import javax.ejb.Local;

import entity.ejb.Recipe;


@Local
public interface RecipeEAOImplLocal {
	public Recipe findByiNumberPNumber(String iNumber, String pNumber);

	public Recipe createRecipe(Recipe recipe);

	public Recipe updateRecipe(Recipe recipe);

	public void deleteRecipe(String iNumber, String pNumber);

}
