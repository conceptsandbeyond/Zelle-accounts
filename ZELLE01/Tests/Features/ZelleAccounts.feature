Feature: Retrieve Zelle accounts based on account type and eligibility
  As a user with different account types
  I want to retrieve a list of eligible Zelle accounts
  So that I can see the correct options based on my account type and eligibility

  Scenario Outline: Retrieve Zelle accounts based on account type and boolean list
    Given I am a <account_type> user
    When I retrieve Zelle eligibility status <boolean_list>
    Then I get <list_of_accounts>

    Examples:
      | account_type             | boolean_list | list_of_accounts       |
      | Retail                   | F            | Retail Zelle           |
      | No accounts/not eligible | F            | False                  |
      | Business                 | F            | Business Zelle         |
      | Mixed Retail/Business    | T            | Based on user choice   |
